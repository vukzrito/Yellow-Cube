import { Component, OnInit } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { VehicleCategory } from 'src/app/models/vehicle-category';
import { AlertService } from 'src/app/services/alert.service';
import { VehicleCategoriesService } from 'src/app/services/vehicle-categories.service';

@Component({
  selector: 'app-vehicle-categories',
  templateUrl: './vehicle-categories.component.html',
  styleUrls: ['./vehicle-categories.component.scss']
})
export class VehicleCategoriesComponent implements OnInit {
  vehicleCategory: VehicleCategory;
  vehicleCategories: VehicleCategory[];
  modal: BsModalRef;
  constructor(private modalService: BsModalService, private alertService: AlertService,
    private vehicleCategoriesService: VehicleCategoriesService) { }

  ngOnInit() {
    this.vehicleCategory = new VehicleCategory();
  }

  loadCategories() {
    this.alertService.startLoadingMessage();
    this.vehicleCategoriesService.getVehicleCategories().subscribe(categories => {
      this.alertService.stopLoadingMessage();
      this.vehicleCategories = categories;
    });
  }

  showAddVehicleCategoryModal(content) {
    this.vehicleCategory = new VehicleCategory();

    this.modal = this.modalService.show(content, {});
  }

}
