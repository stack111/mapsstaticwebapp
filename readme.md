# Vanilla JavaScript App

[Azure Static Web Apps](https://docs.microsoft.com/azure/static-web-apps/overview) allows you to easily build JavaScript apps in minutes. Use this repo with the [quickstart](https://docs.microsoft.com/azure/static-web-apps/getting-started?tabs=vanilla-javascript) to build and customize a new static site.

This repo is used as a starter for a _very basic_ HTML web application using no front-end frameworks.

## Prerequisites

Download [NodeJs](https://nodejs.org/download/)

```powershell
npm install -g @azure/static-web-apps-cli
npm install -g azure-functions-core-tools@3
```

## Run

```powershell
swa start src --api-location src/api
```
