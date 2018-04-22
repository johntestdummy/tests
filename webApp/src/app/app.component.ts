import { Component } from '@angular/core';
import { TwitterService } from './services/twitter.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  
  constructor(private twitterService: TwitterService) { }
  error = false;
  search = {
    query: '',
    count: 10,
    results: []
  };

  searchTwitter() {
    this.reset();
    this.twitterService.search(this.search.query, this.search.count)
      .subscribe(
        data => {
          this.search.results = data;
          console.log(data) 
        },
        error => {
          this.error = true;
          console.log(error)
        }      
    );
  }

  reset(){
    this.error = false;
    this.search.results = [];
  }

}
