import { Component, OnInit } from '@angular/core';
import { ServicesService } from '../../services/services.service';
import { Services } from '../../models/Services';
@Component({
  selector: 'app-services',
  templateUrl: './services.component.html',
  styleUrls: ['./services.component.css'],
  providers: [ ServicesService ]
})
export class ServicesComponent implements OnInit {

  service: Services = new Services();
  services: Services[];

  constructor(private serviceService: ServicesService) { }

  loadServices() {
    this.serviceService.getServices()
      .subscribe((data: Services[]) => this.services = data);
  }

  ngOnInit() {
    this.loadServices();
  }
}
