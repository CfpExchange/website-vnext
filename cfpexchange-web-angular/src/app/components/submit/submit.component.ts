import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-submit',
  templateUrl: './submit.component.html',
  styleUrls: ['./submit.component.scss']
})
export class SubmitComponent implements OnInit {

  public cfpUrl: string | undefined;

  constructor(private httpClient: HttpClient) { }

  ngOnInit(): void {
  }

  public parseCfpUrl() {
    if (this.cfpUrl){
      // This 👇🏻 doesn't work because of CORS, we'll need to do this in the API.
      // this.httpClient.get(this.cfpUrl).subscribe((data) => {
      //   console.log(data);
      // })
    }
  }
}
