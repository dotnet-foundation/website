(async function () {
  let html = "";

  $.ajax({
    url: "/api/issues",
    async: false,
    success: function (repos) {
      html += `<div class="card-columns" style="text-align:center">`;

      repos.forEach((repo) => {
        html += `  <div class="card bg-foundation">
                      <h3>${repo.repoName}</h3>
                      <div class="card-body">`;

        html += ``;
        repo.issues.forEach((issue) => {
          html += `<p class="card-text">
                      <a style="color: white" href="${issue.issueUrl}" target="_blank">${issue.issueTitle}</a>
                   </p>
                   <br />`;
        });
      });
      html += `</div></div>`;
      document.querySelector("#issues").innerHTML = html;
    },
  });
})();
