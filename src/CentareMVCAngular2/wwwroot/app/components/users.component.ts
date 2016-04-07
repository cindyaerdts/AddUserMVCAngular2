import {Component, OnInit} from "angular2/core";

@Component({
    selector: "users",
    templateUrl: "/partial/users"
})
export class UsersComponent implements OnInit {
    message: string;

    constructor() { }

    ngOnInit() {
        this.message = "Users"
    }
}