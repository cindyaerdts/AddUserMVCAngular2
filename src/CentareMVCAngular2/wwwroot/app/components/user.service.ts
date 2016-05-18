import "rxjs/Rx"
import {Http} from "angular2/http";
import {Injectable} from "angular2/core";

@Injectable()
export class UserService {
    constructor(private http: Http) { }

    //get(onNext: (json: any) => void) {
    //    this.http.get("user").map(response => response.json()).subscribe(onNext);

    getUser(userName) {
        var getUserUrl = "user" + '/' + userName;
            this.http.get(getUserUrl);
    }
}