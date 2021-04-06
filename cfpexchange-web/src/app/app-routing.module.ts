import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AboutComponent } from './components/about/about.component';
import { CfpComponent } from './components/cfp/cfp.component';
import { ContactComponent } from './components/contact/contact.component';
import { HomeComponent } from './components/home/home.component';

const routes: Routes = [  {
  path: '',
  component: HomeComponent,
}, {
  path: 'cfps',
  component: CfpComponent,
}, {
  path: 'contact',
  component: ContactComponent,
}, {
  path: 'about',
  component: AboutComponent,
}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
