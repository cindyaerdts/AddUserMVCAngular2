import {Component, OnInit} from "angular2/core";
import {CORE_DIRECTIVES} from "angular2/src/common/directives/core_directives";
import {UserService} from "./user.service";

@Component({
    selector: "users",
    templateUrl: "/partial/users",
    providers: [UserService],
    directives: CORE_DIRECTIVES
})
export class UsersComponent implements OnInit {
    isLoading: boolean = false;
    data: string[];
    message: string;

    constructor(private service: UserService) { }

    ngOnInit() {
        this.get();
    }

    get() {
        this.isLoading = true;
        this.service.getUser(userName => {
            if (userName) {
                this.data = userName.users;
                this.isLoading = false;
            }
        });
    }
}