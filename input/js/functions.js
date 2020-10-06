function loadOpenIssues(orgs, repos, showEmptyCard, repoName) {
  let html = "";

  var data = {
    organization: orgs,
    repos: repos,
  };

  var json = JSON.stringify(data);

  $.ajax({
    url: "/api/issues",
    type: "POST",
    data: json,
    async: false,
    success: function (repos) {
      if (repos.length == 0) {
        if (showEmptyCard) {
          html += `  <div class="card card--features bg-foundation">
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
          html += `  <div class="card card--features bg-foundation">
          <div class="card-body">`;

          if (repoName != undefined)
          {
            html += `<h3>${repoName} Help Wanted</h3>`;
          }
          else
          {
            html += ` <h3>${repo.repoName} Help Wanted</h3>`;
          }

          html += `<div class="card-body">`;

          if (repo.issues.length > 4) {
            repo.issues = repo.issues.slice(0, 5);
          }

          repo.issues.forEach((issue) => {
            html += `<p class="card-text">
                        <a style="color: white" href="${issue.issueUrl}" target="_blank">${issue.issueTitle}</a>
                     </p>`;
          });
          html += `</div></div></div>`;
        });
      }
      document.querySelector("#issues").innerHTML = html;
    },
    error: function (jqXHR, textStatus, errorThrown) {
      if (showEmptyCard) {
        html += `  <div class="card card--features bg-foundation">
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
      document.querySelector("#issues").innerHTML = html;
    },
  });
}
