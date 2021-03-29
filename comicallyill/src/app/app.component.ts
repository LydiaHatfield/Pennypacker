import { Component } from '@angular/core';
import { DashboardComponent} from './dashboard/index';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
  directives: [DashboardComponent]
})
export class AppComponent {
  title = 'comicallyill';
}
