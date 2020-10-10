import { AzureFunction, Context, HttpRequest } from "@azure/functions";
import * as fs from "fs";
import * as path from "path";

const httpTrigger: AzureFunction = async function (
  context: Context,
  req: HttpRequest
): Promise<void> {
  let projects = [];

  let files = fs.readdirSync(__dirname);

  files.forEach((file) => {
    if (file != "function.json" && path.extname(file) == ".json") {
      const data = fs.readFileSync(path.join(__dirname, file), {
        encoding: "utf8",
        flag: "r",
      });
      var project = JSON.parse(data);
      projects.push(project);
    }
  });

  projects = projects.sort(function (a, b) {
    let aDate = new Date(a.publishDate);
    let bDate = new Date(b.publishDate);
    if (aDate > bDate) return -1;
    if (aDate < bDate) return 1;
    return 0;
  });
  context.res = {
    status: 200,
    headers: {
      "Content-Type": "application/json",
    },
    body: projects,
  };
};

export default httpTrigger;
