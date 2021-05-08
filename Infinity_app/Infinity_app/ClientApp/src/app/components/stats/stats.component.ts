import { Component, OnInit } from '@angular/core';
import { StatsService } from '../../services/stats.service';
import { Stats } from '../../models/Stats';

@Component({
  selector: 'app-stats',
  templateUrl: './stats.component.html',
  styleUrls: ['./stats.component.css'],
  providers: [ StatsService ]
})
export class StatsComponent implements OnInit {

  stat: Stats = new Stats();
  stats: Stats[];

  constructor(private statsService: StatsService) { }

  loadStats() {
    this.statsService.getStats()
      .subscribe((data: Stats[]) => this.stats = data);
  }

  ngOnInit() {
    this.loadStats();
  }
}
