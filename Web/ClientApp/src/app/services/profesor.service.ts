import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn:'root'
})
export class ProfesorService {

  _url = 'api/characters/staff'
  constructor(
    private http:HttpClient  ) {
    console.log('servicio de persona');

  }

  getProfesores() {
    let header = new HttpHeaders()
      .set('Type-content', 'aplication/json')

    return this.http.get(this._url, {
      headers: header
    })
  }
}
