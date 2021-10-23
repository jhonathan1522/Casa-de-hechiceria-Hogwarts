import { Component } from '@angular/core';
import { ProfesorService } from '../services/profesor.service';

@Component({
    selector: 'app-profesor',
    templateUrl: './profesor.component.html',
    styleUrls: ['./profesor.component.css']
})
/** profesor component*/
export class ProfesorComponent {
  /** profesor ctor */
  public profesores: Array<any> = []
  constructor(
    private profesorService: ProfesorService
  ) {
    debugger;
    this.profesorService.getProfesores().subscribe((resp:any) => {
      this.profesores = resp
      console.log(this.profesores)
    })
  }
}
