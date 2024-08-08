import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';


import { importProvidersFrom } from '@angular/core';
import { AppComponent } from './app/app.component';
import { withInterceptorsFromDi, provideHttpClient } from '@angular/common/http';
import { BrowserModule, bootstrapApplication } from '@angular/platform-browser';
import { appRouterProviders } from './app/app.routes';


bootstrapApplication(AppComponent, {
    providers: [
        appRouterProviders,
        provideHttpClient(withInterceptorsFromDi())
    ]
})
  .catch(err => console.error(err));
