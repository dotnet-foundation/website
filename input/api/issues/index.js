"use strict";
var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
Object.defineProperty(exports, "__esModule", { value: true });
const rest_1 = require("@octokit/rest");
const octokit = new rest_1.Octokit();
const fs = require("fs");
const path = require("path");
class ViewModel {
    constructor(date, data) {
        if (Object.prototype.toString.call(date)) {
            date = new Date(date);
        }
        this.date = date;
        this.data = data;
    }
}
function getIssues() {
    return __awaiter(this, void 0, void 0, function* () {
        const organization = "dotnet-foundation";
        const repos = [
            "wg-marketing" //,
            // "website",
            // "wg-outreach",
            // "speaking",
            // "membership",
            // "newsletter",
            // "content",
            // "projects",
            // "events",
            // "wg-education",
            // "wg-technical-review",
            // "wg-speakers-and-meetups",
            // "wg-project-support",
            // "wg-membership",
        ];
        const issuesByRepoPromises = repos.map((repo) => octokit.issues
            .listForRepo({
            repo,
            owner: organization,
            labels: "help wanted",
        })
            .then((r) => r.data));
        const issuesByRepo = yield Promise.all(issuesByRepoPromises);
        return issuesByRepo.reduce((list, item) => list.concat(item), []);
    });
}
function processIssues(issues) {
    return __awaiter(this, void 0, void 0, function* () {
        let issueArray = [];
        issues.forEach((issue) => {
            let tempArray = issue.repository_url.split("/");
            let r = {
                repoName: tempArray[tempArray.length - 1],
                issueTitle: issue.title,
                issueUrl: issue.html_url,
            };
            issueArray.push(r);
        });
        const issueMap = issueArray.reduce((m, v) => {
            const repo = v.repoName;
            const entry = m[repo];
            if (typeof entry === "undefined") {
                m[repo] = [v];
            }
            else {
                entry.push(v);
            }
            return m;
        }, {});
        const groupedIssues = Object.keys(issueMap).map((d) => {
            return {
                repoName: d,
                issues: issueMap[d],
            };
        });
        let model = new ViewModel(new Date(), groupedIssues);
        return model;
    });
}
const httpTrigger = function (context, req) {
    return __awaiter(this, void 0, void 0, function* () {
        var filepath = "issues.json";
        try {
            const data = fs.readFileSync(path.join(__dirname, filepath), {
                encoding: "utf8",
                flag: "r",
            });
            var obj = JSON.parse(data);
            let model = new ViewModel(obj.date, obj.data);
            var now = new Date();
            var diff = now.getTime() - model.date.getTime();
            var hours = Math.floor(diff / (1000 * 60 * 60));
            if (hours > 24) {
                model = yield processIssues(yield getIssues());
                fs.writeFileSync(path.join(__dirname, filepath), JSON.stringify(model), "utf8");
                context.res = {
                    status: 200,
                    headers: {
                        "Content-Type": "application/json",
                    },
                    body: model.data,
                };
            }
            else {
                context.res = {
                    status: 200,
                    headers: {
                        "Content-Type": "application/json",
                    },
                    body: model.data,
                };
            }
        }
        catch (_a) {
            let model = yield processIssues(yield getIssues());
            fs.writeFileSync(path.join(__dirname, filepath), JSON.stringify(model), "utf8");
            context.res = {
                status: 200,
                headers: {
                    "Content-Type": "application/json",
                },
                body: model.data,
            };
        }
    });
};
exports.default = httpTrigger;
//# sourceMappingURL=index.js.map