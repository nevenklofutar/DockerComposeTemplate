import { Component, OnInit } from '@angular/core';
import { Person } from './models/person';
import { ApplicationService } from './services/application.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Client';
  people: Person[] = [];

  constructor(private appService: ApplicationService) {}

  ngOnInit() {
    this.appService.getAllPeople().subscribe(
      (result) => {
        this.people = result;
      }
    );
  }
}
