//Project Play

//import file
import { Component, OnInit, Input} from '@angular/core';

//decorator
@Component({
    selector: 'play-project',
    templateUrl: './project.component.html',
    styleUrls: ['./project.component.css']
 })

//export class
export class ProjectComponent implements OnInit {
    
    //declare variables 
    @Input() projectName: string;
    @Input() totalTime: string;
    @Input() totalMembers: number;
    @Input() projectIcon: string;
    
    //declare constructor 
    constructor() { }
  
    //declare ngOnInit
    ngOnInit(): void {
        //call functions
        this.displayProjectName();
        this.displayTotalTime();
        this.displayTotalMembers();
        this.displayProjectIcon();
    }
    
    //define functions
    displayProjectName() {
        console.log("The Project Name is: "+this.projectName);
    }

    displayTotalTime() {
        console.log("The Total Time of the Project is: "+this.totalTime);
    }

    displayTotalMembers() {
        console.log("The Total Number of Members involved in the Project are: "+this.totalMembers);
    }

    displayProjectIcon() {
        console.log("The Icon of the Project is: "+this.projectIcon);
    }
 
}//end of class