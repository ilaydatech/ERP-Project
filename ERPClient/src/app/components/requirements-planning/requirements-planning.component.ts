import { ActivatedRoute } from '@angular/router';
import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { HttpService } from '../../services/http.service';
import { RequirementsPlanningModel } from '../../models/requirements-planning.model';

@Component({
  selector: 'app-requirements-planning',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './requirements-planning.component.html',
  styleUrl: './requirements-planning.component.css'
})
export class RequirementsPlanningComponent {
  data: RequirementsPlanningModel = new RequirementsPlanningModel();
  orderId: string = "";

  constructor(
    private activated: ActivatedRoute,
    private http: HttpService
  ) {
    this.activated.params.subscribe(res => {
      this.orderId = res["orderId"];
      this.get();
    });
  }

  get() {
    this.http.post<RequirementsPlanningModel>("Orders/RequirementsPlanningByOrderId", { orderId: this.orderId }, res => {
      this.data = res;
    });
  }
}