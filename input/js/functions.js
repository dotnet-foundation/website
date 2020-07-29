function loadOpenIssues(orgs, repos, showEmptyCard) {
  let html = "";

  var data = {
    organization: orgs,
    repos: repos,
  };

  var json = JSON.stringify(data);

  $.ajax({
    //url: "/api/issues",
    url: "http://localhost:7071/api/issues",
    type: "POST",
    data: json,
    async: false,
    success: function (repos) {
      if (repos.length == 0) {
        if (showEmptyCard) {
          html += `  <div class="card bg-foundation">
        <h3>Help Wanted</h3>
        <div class="card-body">
        <p class="card-text">
        </p>
        <br />
        <p class="card-text">
        </p>
        <br />
        <p class="card-text">
        </p>
        <br />
        <p class="card-text">
        </p>
        <br />
        <p class="card-text">
        </p>
        <p class="card-text">
        </p>`;
        }
      } else {
        repos.forEach((repo) => {
          html += `  <div class="card bg-foundation">
                        <h3>${repo.repoName} Help Wanted</h3>
                        <div class="card-body">`;

          if (repo.issues.length > 4) {
            repo.issues = repo.issues.slice(0,5);
          }

          repo.issues.forEach((issue) => {
            html += `<p class="card-text">
                        <a style="color: white" href="${issue.issueUrl}" target="_blank">${issue.issueTitle}</a>
                     </p>`;
          });
          html += `</div></div>`;
        });
      }
      document.querySelector("#issues").innerHTML = html;
    },
  });
}
