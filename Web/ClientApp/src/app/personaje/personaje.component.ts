import { Component } from '@angular/core';
import { PersonajeService } from '../services/personaje.service';

@Component({
    selector: 'app-personaje',
    templateUrl: './personaje.component.html',
    styleUrls: ['./personaje.component.css']
})
/** personaje component*/
export class PersonajeComponent {

  public personajes: Array<any> = []
    /** personaje ctor */
  constructor(
    private personajeService: PersonajeService
  ) {
    debugger;
    this.personajeService.getPersonajes().subscribe((resp: any) => {
      this.personajes = resp
      console.log(this.personajes)
    })
    }
}
