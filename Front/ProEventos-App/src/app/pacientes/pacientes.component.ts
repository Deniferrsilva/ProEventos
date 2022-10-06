import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
// import { CommonModule } from '@angular/common';


@Component({
  selector: 'app-pacientes',
  templateUrl: './pacientes.component.html',
  styleUrls: ['./pacientes.component.css']

})
export class PacientesComponent implements OnInit {

  public pacientes: any;
  data1 = new Date('2021-04-23T10:00:00.000Z');
  constructor(private http: HttpClient ) { }

  ngOnInit() {
    this.getPacientes();
  }

public  getPacientes(): void {
  this.http.get('https://localhost:5001/api/pacientes').subscribe(
    response => this.pacientes = response,
    error => console.log(error)
  )
}

}
