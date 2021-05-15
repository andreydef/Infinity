import { Component, OnInit } from '@angular/core';
import { LinksService } from '../../services/links.service';
import { Links } from '../../models/Links';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
  providers: [ LinksService ]
})

export class HomeComponent implements OnInit {
  link: Links = new Links();
  links: Links[];

  constructor(private linkService: LinksService) { }

  loadLinks() {
    this.linkService.getLinks()
      .subscribe((data: Links[]) => this.links = data);
  }

  ngOnInit() {
    this.loadLinks();
  }
}
