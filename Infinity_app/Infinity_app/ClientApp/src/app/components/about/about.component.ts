import { Component, OnInit } from '@angular/core';
import { AboutService } from '../../services/about.service';
import { About } from '../../models/About';

@Component({
  selector: 'app-about',
  templateUrl: '../about/about.component.html',
  styleUrls: ['../about/about.component.css'],
  providers: [ AboutService ]
})
export class AboutComponent implements OnInit {

  about: About = new About();
  abouts: About[];

  constructor(private aboutService: AboutService) { }

  loadAbouts() {
    this.aboutService.getAbouts()
      .subscribe((data: About[]) => this.abouts = data);
  }

  ngOnInit() {
    this.loadAbouts();
  }
}
