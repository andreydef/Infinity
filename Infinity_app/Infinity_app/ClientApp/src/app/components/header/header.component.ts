import { Component, OnInit } from '@angular/core';
import { Links } from '../../models/Links';
import { LinksService } from '../../services/links.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css'],
  providers: [ LinksService ]
})
export class HeaderComponent implements OnInit {
  links: Links[];

  constructor(private linksService: LinksService) { }

  loadLinks() {
    this.linksService.getLinks()
      .subscribe((data: Links[]) => this.links = data);
  }

  ngOnInit() {
    this.loadLinks();
  }
}
