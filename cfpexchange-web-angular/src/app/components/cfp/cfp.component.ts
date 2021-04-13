import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

import { Cfp } from 'src/app/models/cfp';
import { CfpService } from 'src/app/services/cfp.service';

@Component({
  selector: 'app-cfp',
  templateUrl: './cfp.component.html',
  styleUrls: ['./cfp.component.scss']
})
export class CfpComponent implements OnInit {

public cfps$: Observable<Cfp[]> | undefined;

  constructor(private cfpService: CfpService) { }

  ngOnInit(): void {
    this.cfps$ = this.cfpService.getCfps();
  }

}
