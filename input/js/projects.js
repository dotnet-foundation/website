String.prototype.format = function () {
    a = this;
    for (k in arguments) {
        a = a.replace("{" + k + "}", arguments[k]);
    }
    return a;
};

String.prototype.isLetter = function () {
    c = this;
    return c.toLowerCase() !== c.toUpperCase();
}

let formInput = document.getElementById('textToSearch'),
    formSubmit = document.getElementById('search-projects'),
    presetProjects = document.getElementById('PresetProjects'),
    searchResults = document.getElementById('SearchResults')
    totalFilteredDocuments = 0,
  projects = [];


$('#back-button').on('click', () => {
  console.log('click');
  $('#search-description').html('');
  $('#search').css('display', 'block');
  $('#foundation-description').css('display', 'block');
  $('#back-button').css('display', 'none');
  $('#submit-button').css('display', 'inline-block');

     searchResults.hidden = true;
        presetProjects.hidden = false;
  formInput.value = '';
})


let projectsRow = (items) => (
  `<div class="row">
      ${items.map((item) => (
        `<div class="col-lg-4 col-sm-12 alph">
          <hr />
          <div class="alph-box">
            <div class="letter">${item.title}</div>
            <div class="list">
              ${item.data.sort((a, b) => a.Title.localeCompare(b.Title)).map((li) => (
                  `<a class="project-item" href='${li.Link}' data-project='${li.Title}'>${li.Title}</a>`
              )).join('')}
            </div>
          </div>
        </div >`
       )).join('')}
    </div>`
);

let projectsList = (list) => {
  let orderedArray = getAlphabeticallyOrderedArray(list).sort((a, b) => a.title.localeCompare(b.title));
  let html = '';
  while (orderedArray.length > 0) {
    html = `${html}${projectsRow(orderedArray.slice(0, 3))}`;
    orderedArray.splice(0, 3);
  }
  return html;
};


const getAlphabeticallyOrderedArray = (list) => {
  if (list.length === 0) {
    return [];
  }
  return Object.values(
    list.reduce((acc, item) => {
      let firstLetter = item.Title[0].toLocaleUpperCase();
      if (!firstLetter.isLetter()) {
        firstLetter = "#";
      }
      if (!acc[firstLetter]) {
        acc[firstLetter] = { title: firstLetter, data: [item] };
      } else {
        acc[firstLetter].data.push(item);
      }
      return acc;
    }, {})
  );
}

formSubmit.addEventListener('click', function () {
    searchProjects();
});

formInput.addEventListener('keyup', function (e) {
  if (e.code === 'Enter') {
    searchProjects();
  }
});

fetch('/projects/projects.json')
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
    let textToSearch = formInput.value.toLowerCase();
    let newProjects = [];
    if (textToSearch === "") {
        searchResults.hidden = true;
        presetProjects.hidden = false;
      totalFilteredDocuments = projects.length; 
      $('#search-description').html('');
      $('#search').css('display', 'block');
      $('#foundation-description').css('display', 'block');
      $('#back-button').css('display', 'none');
      $('#submit-button').css('display', 'inline-block');
    } else {
        projects.forEach(p => {
            if (p.Content.toLowerCase().includes(textToSearch)
                || p.Title.toLowerCase().includes(textToSearch)) {
                newProjects.push(p);
            }
        });
        totalFilteredDocuments = newProjects.length;

        searchResults.hidden = false;
        presetProjects.hidden = true;
      $('#search-description').html(`Showing search results for "${formInput.value}"`);
      $('#search').css('display', 'none');
      $('#foundation-description').css('display', 'none');
      $('#back-button').css('display', 'inline-block');
      $('#submit-button').css('display', 'none');
    }


    loadLists(newProjects);
};

let loadLists = (projectsToShow) => {

    searchResults.innerHTML = projectsList(projectsToShow);
};

