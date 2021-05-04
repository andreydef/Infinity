import { Component, OnInit } from '@angular/core';
import { ResumeService } from '../../services/resume.service';
import { Resume } from '../../models/Resume';

@Component({
  selector: 'app-resume',
  templateUrl: './resume.component.html',
  styleUrls: ['./resume.component.css'],
  providers: [ ResumeService ]
})
export class ResumeComponent implements OnInit {

  resume: Resume = new Resume();
  resumes: Resume[];

  constructor(private resumeService: ResumeService) { }

  loadResumes() {
    this.resumeService.getResumes()
      .subscribe((data: Resume[]) => this.resumes = data);
  }

  ngOnInit() {
    this.loadResumes();
  }
}
