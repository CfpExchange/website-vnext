import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Contributor } from '../models/contributor';

@Injectable({
  providedIn: 'root'
})
export class GithubService {

  constructor(private httpClient: HttpClient) { }

  public getContributors() {
    return this.httpClient.get<Contributor[]>('https://api.github.com/repos/cfpexchange/cfpexchange/contributors')
  }
}
