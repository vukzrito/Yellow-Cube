import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { VehicleCategory } from '../models/vehicle-category';
import { AuthService } from './auth.service';
import { ConfigurationService } from './configuration.service';
import { EndpointBase } from './endpoint-base.service';

@Injectable({
  providedIn: 'root'
})
export class VehicleCategoriesService extends EndpointBase {

  constructor(private configService: ConfigurationService, http: HttpClient, authService: AuthService) {
    super(http, authService);
  }

  getVehicleCategories(): Observable<VehicleCategory[]> {
    return this.http.get<VehicleCategory[]>(`${this.configService.baseUrl}/api/vehicleCategories`, this.requestHeaders);
  }

  createVehicleCategory(vehicleCategory: VehicleCategory) {
    return this.http.post(`${this.configService.baseUrl}/api/vehicleCategories`, vehicleCategory, this.requestHeaders);
  }
}
