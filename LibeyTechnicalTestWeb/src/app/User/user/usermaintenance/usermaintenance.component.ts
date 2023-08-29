import swal from 'sweetalert2';
import { Component, OnInit } from '@angular/core';
import { LibeyUserService } from 'src/app/core/service/libeyuser/libeyuser.service';
import { InsertLibeyUserRequest } from 'src/app/core/requests/libey-user/libey-user.request';

@Component({
  selector: 'app-usermaintenance',
  templateUrl: './usermaintenance.component.html',
  styleUrls: ['./usermaintenance.component.css']
})


export class UsermaintenanceComponent implements OnInit {
  constructor(private libeyUserService: LibeyUserService) {}
  libeyUser: InsertLibeyUserRequest = { documentNumber: "", documentTypeId: 0, name: "", phone: "", fathersLastName: "", mothersLastName: "", address: "", email: "", regionCode: "", provinceCode: "", ubigeoCode: "", password: "", active: true}
  ngOnInit(): void {}
  onSubmit(){
    this.libeyUserService.Insert(this.libeyUser);
  }
}