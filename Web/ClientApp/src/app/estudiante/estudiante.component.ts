import { Component } from '@angular/core';
import { EstudianteService } from '../services/estudiante.service';

@Component({
    selector: 'app-estudiante',
    templateUrl: './estudiante.component.html',
    styleUrls: ['./estudiante.component.css']
})
/** estudiante component*/
export class EstudianteComponent {

  public estudiantes: Array<any> = []

    /** estudiante ctor */
  constructor(
    private estudianteService: EstudianteService
  ) {

    debugger;
    this.estudianteService.getEstudiantes().subscribe((resp: any) => {
      this.estudiantes = resp
      console.log(this.estudiantes)
    })

    }

}
