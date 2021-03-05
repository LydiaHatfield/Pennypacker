import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {DashboardComponent} from './dashboard/dashboard.component';
import {ArchivesComponent} from './archives/archives.component';
import {AuthorsComponent} from './authors/authors.component';
import {ContactComponent} from './contact/contact.component';
import {Router, RouterModule, Routes} from '@angular/router';

const routes : Routes=[
{path: 'dashboard', component: DashboardComponent},
{path: 'archives', component: ArchivesComponent},
{path: 'authors', component: AuthorsComponent},
{path: 'contact', component: ContactComponent},
{path: 'blog', component: DashboardComponent}
];

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forRoot(routes)
  ],
  exports: [
    RouterModule
  ]
})
export class AppRoutingModule { }
