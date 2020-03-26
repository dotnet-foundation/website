String.prototype.format = function () {
    a = this;
    for (k in arguments) {
        a = a.replace("{" + k + "}", arguments[k]);
    }
    return a;
};

var converter = new showdown.Converter();

let formInput = document.getElementById('textToSearch'),
    presetProjects = document.getElementById('PresetProjects'),
    presetPagination = document.getElementById('PresetPagination'),
    searchServiceName = formInput.getAttribute('azure-search-name'),
    searchServiceIndex = formInput.getAttribute('azure-search-index'),
    searchServiceApiVersion = formInput.getAttribute('azure-search-api-version'),
    searchServiceApiKey = formInput.getAttribute('azure-search-api-key'),
    searchserviceRpp = formInput.getAttribute('azure-search-rpp'),
    searchEndpoint = `https://{0}.search.windows.net/indexes/{1}/docs/?api-version={2}&search={3}&$skip={4}&$top={5}&$count=true`,
    documentsCounterEndpoint = `https://{0}.search.windows.net/indexes/{1}/docs/$count?api-version={2}`,
    headers = {
        "Accept": "application/json",
        "Content-Type": "application/json; charset=utf-8",
        'X-Requested-With': 'XMLHttpRequest',
        'api-key': searchServiceApiKey
    },
    searchServiceTotalDocuments = 0;

let projectListItem = (item) =>(
    `<article class="row">
      <div class="col-4"><a href="${item.contributorUrl}"><img class="img-responsive contrib-logos" src="${item.contributorLogo}" alt="Telerik"></a></div>
      <div class="col-8" data-mdurl="https://raw.githubusercontent.com/dotnet/foundation/master/projects/${item.descriptionMarkdownFilename}">
        ${converter.makeHtml(item.descriptionMarkdown)}
      </div>
    </article>
    <hr>`
);

let projectsList = (list) => (
    `${list.map(projectListItem).join('')}`
);

let paginationButtons = () => {
    let paginationHtml = '';
    if (searchServiceTotalDocuments > 0) {
        let currentPage = formInput.getAttribute('azure-search-page') * 1;
        let numberOfPages = Math.floor(searchServiceTotalDocuments / searchserviceRpp);
        let latestPage = numberOfPages;
        let latestPageRecords = searchServiceTotalDocuments % searchserviceRpp;
        paginationHtml += `<ul class="pagination d-flex flex-wrap">`;
        if (currentPage === 1) {
            paginationHtml += `<li class="page-item disabled" title="Previous Page"><span class="page-link">«</span></li>`;
        } else {
            paginationHtml += `<li class="page-item" azure-search-page="${(currentPage - 1)}" title="Previous Page"><span class="page-link"azure-search-page="${(currentPage - 1)}">«</span></li>`;
        }

        for (let i = 1; i <= numberOfPages; i++) {
            if (i === currentPage) {
                paginationHtml += `<li class="page-item active"><span class="page-link" azure-search-page="${i}">${i}</span></li>`;
            } else {
                paginationHtml += `<li class="page-item" azure-search-page="${i}"><span class="page-link" azure-search-page="${i}">${i}</span></li>`;
            }
        }
        if (latestPageRecords !== 0) {
            latestPage = latestPage + 1;
            if (currentPage === latestPage) {
                paginationHtml += `<li class="page-item active"><span class="page-link">${(numberOfPages + 1)}</span></li>`;
            } else {
                paginationHtml += `<li class="page-item" azure-search-page="${(numberOfPages + 1)}"><span class="page-link" azure-search-page="${(numberOfPages + 1)}">${(numberOfPages + 1)}</span></li>`;
            }
        }

        if (currentPage === latestPage) {
            paginationHtml += `<li class="page-item disabled"><span class="page-link" title="Next page">»</span></li>`;
        } else {
            paginationHtml += `<li class="page-item" azure-search-page="${(currentPage + 1)}"><span class="page-link" azure-search-page="${(currentPage + 1)}" title="Next page">»</span></li>`;
        }

        paginationHtml += `</ul>`;
    }
    return paginationHtml;
};

let addEventListenerToPaginationButtons = () => {
    let buttons = document.querySelectorAll('li[azure-search-page]');
    buttons.forEach(function (button) {
        button.addEventListener("click", function (event) {
            let page = event.target.getAttribute('azure-search-page');
            formInput.setAttribute('azure-search-page', page);
            searchProjects();
        });
    });
};

formInput.addEventListener('keyup', function () {
    formInput.setAttribute('azure-search-page', 1);
    searchProjects();
});

fetch(documentsCounterEndpoint.format(searchServiceName, searchServiceIndex, searchServiceApiVersion), {
    method: "GET",
    cache: "no-cache",
    credentials: "same-origin",
    headers: headers
})
    .then(response => response.json())
    .then(data => {
        searchServiceTotalDocuments = data;
        searchProjects();
    })
    .catch(error => console.log(error));

let searchProjects = () => {
    let azureSearchPage = formInput.getAttribute('azure-search-page') - 1;
    let skip = azureSearchPage * searchserviceRpp;
    let textToSearch = formInput.value === "" ? "*" : formInput.value;
    fetch(searchEndpoint.format(searchServiceName, searchServiceIndex, searchServiceApiVersion, textToSearch, skip, searchserviceRpp), {
        method: "GET",
        credentials: "same-origin",
        headers: headers
    })
        .then(response => response.json())
        .then(json => {
            searchServiceTotalDocuments = json['@odata.count'];
            loadLists(json);
        })
        .catch(error => console.log(error));
};

let loadLists = (json) => {
    let projects = [...json.value],
        searchSuggest = ['input', function (e) {
            filterList(event.target.value, projects);
        }, false];

    formInput.addEventListener(...searchSuggest);
    presetProjects.innerHTML = projectsList(projects.slice(0, searchserviceRpp));
    presetPagination.innerHTML = paginationButtons();
    addEventListenerToPaginationButtons();
    formInput.scrollIntoView();
};

let filterList = (key, projects) => {

};
