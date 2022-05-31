import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { environment } from "src/environments/environment";
import { Person } from "../models/person";

@Injectable({ providedIn: 'root'})
export class ApplicationService {

  constructor(private http: HttpClient) {}

  getAllPeople() {
    return this.http.get<Person[]>(`${environment.apiUrl}people`)
  }

  getPersonById(personId: number) {
    return this.http.get<Person>(`${environment.apiUrl}people/${personId}`)
  }
}
