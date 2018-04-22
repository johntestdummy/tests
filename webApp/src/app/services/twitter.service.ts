import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class TwitterService {

  constructor(private http: HttpClient) { }

  search(q: string, count: number) : Observable<any> {
    const uri = environment.endpoints.twitter.search + 'query=' + q + '&count=' + count;
    return this.http.get(uri);
  }

}
