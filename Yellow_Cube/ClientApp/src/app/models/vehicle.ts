import { User } from './user.model';
import { VehicleCategory } from './vehicle-category';

export class Vehicle {
    id: string;
    driverId: string;
    driver: User;
    make: string;
    model: string;
    variant: string;
    year: number;
    VIN: string;
    registrationNo: string;
    vehicleCategoryId: string;
    vehicleCategory: VehicleCategory;
}