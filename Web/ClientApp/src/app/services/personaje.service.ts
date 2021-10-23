import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable(
  {
    providedIn: 'root'
  })
export class PersonajeService {

  _url = 'api/characters/staff'
  constructor(
    private http: HttpClient
  ) {
    console.log('servicio de personaje');
  }

  getPersonajes() {
    let header = new HttpHeaders()
      .set('Type-content', 'aplication/json')

    return this.http.get(this._url, {
      headers: header
    })
  }
}
