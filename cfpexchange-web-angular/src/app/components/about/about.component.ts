import { Component, OnInit } from '@angular/core';

import { Observable } from 'rxjs';

import { Contributor } from 'src/app/models/contributor';
import { GithubService } from 'src/app/services/github.service';

@Component({
  selector: 'app-about',
  templateUrl: './about.component.html',
  styleUrls: ['./about.component.scss']
})
export class AboutComponent implements OnInit {

public contributors$: Observable<Contributor[]> | undefined;

  constructor(private githubService: GithubService) { }

  ngOnInit(): void {
    this.contributors$ = this.githubService.getContributors();
  }
}
