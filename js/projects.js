String.prototype.format = function () {
    a = this;
    for (k in arguments) {
        a = a.replace("{" + k + "}", arguments[k]);
    }
    return a;
};

var converter = new showdown.Converter();

let formInput = document.getElementById('textToSearch'),
    formSubmit = document.getElementById('search-projects'),
    presetProjects = document.getElementById('PresetProjects'),
    presetPagination = document.getElementById('PresetPagination'),
    currentPage = 1,
    searchRpp = 10,
    totalFilteredDocuments = 0,
    projects = [];

let projectListItem = (item) =>(
    `<article class="row">
      <div class="col-4"><a href="${item.Web}"><img class="img-responsive contrib-logos" src="assets/projects/${item.Logo}" alt="${item.Title}"></a></div>
      <div class="col-8">
        ${converter.makeHtml(item.Content)}
      </div>
    </article>
    <hr>`
);

let projectsList = (list) => (
    `${list.map(projectListItem).join('')}`
);

let paginationButtons = () => {
    let paginationHtml = '';
    if (totalFilteredDocuments > 0) {
        let numberOfPages = Math.floor(totalFilteredDocuments / searchRpp);
        let latestPage = numberOfPages;
        let latestPageRecords = totalFilteredDocuments % searchRpp;
        paginationHtml += `<ul class="pagination d-flex flex-wrap">`;
        if (currentPage === 1) {
            paginationHtml += `<li class="page-item disabled" title="Previous Page"><span class="page-link">«</span></li>`;
        } else {
            paginationHtml += `<li class="page-item" projects-page="${(currentPage - 1)}" title="Previous Page"><span class="page-link"projects-page="${(currentPage - 1)}">«</span></li>`;
        }

        for (let i = 1; i <= numberOfPages; i++) {
            if (i === currentPage) {
                paginationHtml += `<li class="page-item active"><span class="page-link" projects-page="${i}">${i}</span></li>`;
            } else {
                paginationHtml += `<li class="page-item" projects-page="${i}"><span class="page-link" projects-page="${i}">${i}</span></li>`;
            }
        }
        if (latestPageRecords !== 0) {
            latestPage = latestPage + 1;
            if (currentPage === latestPage) {
                paginationHtml += `<li class="page-item active"><span class="page-link">${(numberOfPages + 1)}</span></li>`;
            } else {
                paginationHtml += `<li class="page-item" projects-page="${(numberOfPages + 1)}"><span class="page-link" projects-page="${(numberOfPages + 1)}">${(numberOfPages + 1)}</span></li>`;
            }
        }

        if (currentPage === latestPage) {
            paginationHtml += `<li class="page-item disabled"><span class="page-link" title="Next page">»</span></li>`;
        } else {
            paginationHtml += `<li class="page-item" projects-page="${(currentPage + 1)}"><span class="page-link" projects-page="${(currentPage + 1)}" title="Next page">»</span></li>`;
        }

        paginationHtml += `</ul>`;
    }
    return paginationHtml;
};

let addEventListenerToPaginationButtons = () => {
    let buttons = document.querySelectorAll('li[projects-page]');
    buttons.forEach(function (button) {
        button.addEventListener("click", function (event) {
            let page = event.target.getAttribute('projects-page');
            currentPage = parseInt(page);
            searchProjects();
        });
    });
};

formSubmit.addEventListener('click', function () {
    currentPage = 1;
    searchProjects();
});

formInput.addEventListener('keyup', function () {
    currentPage = 1;
    searchProjects();
});

fetch('data/projects.json')
    .then(response => {
        if (!response.ok) {
            throw new Error("HTTP error " + response.status);
        }
        return response.json();
    })
    .then(json => {
        projects = json;
        searchProjects();
    })
    .catch(function () {
    });

let searchProjects = () => {
    let skip = (currentPage - 1) * searchRpp;
    let textToSearch = formInput.value.toLowerCase();
    let newProjects = [];
    if (textToSearch === "") {
        newProjects = [...projects];
        totalFilteredDocuments = projects.length;        
    } else {
        projects.forEach(p => {
            if (p.Content.toLowerCase().includes(textToSearch)
                || p.Title.toLowerCase().includes(textToSearch)) {
                newProjects.push(p);
            }
        });
        totalFilteredDocuments = newProjects.length;
    }
    newProjects.splice(0, skip);
    loadLists(newProjects);
};

let loadLists = (projectsToShow) => {
    presetProjects.innerHTML = projectsList(projectsToShow.slice(0, searchRpp));
    presetPagination.innerHTML = paginationButtons();
    addEventListenerToPaginationButtons();
};
