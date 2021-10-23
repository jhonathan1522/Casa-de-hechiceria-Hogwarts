import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable(
  {
      providedIn:'root'
  })
export class EstudianteService {

  _url = 'api/characters/students'
  constructor(
    private http: HttpClient
  ) {
    console.log('servicio de estudiante');
  }


  getEstudiantes() {
    let header = new HttpHeaders()
      .set('Type-content', 'aplication/json')

    return this.http.get(this._url, {
      headers: header
    })
  }
}
