import { Component, OnInit } from '@angular/core';
import { AboutService } from '../../services/about.service';
import { LinksService } from '../../services/links.service';
import { About } from '../../models/About';
import { Links } from '../../models/Links';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
  providers: [ LinksService, AboutService ]
})

export class HomeComponent implements OnInit {

  link: Links = new Links();
  links: Links[];

  about: About = new About();
  abouts: About[];

  constructor(private linkService: LinksService, private aboutService: AboutService) { }

  loadLinks() {
    this.linkService.getLinks()
      .subscribe((data: Links[]) => this.links = data);
  }

  loadAbouts() {
    this.aboutService.getAbouts()
      .subscribe((data: About[]) => this.abouts = data);
  }

  ngOnInit() {
    this.loadLinks();
    this.loadAbouts();
  }
}
