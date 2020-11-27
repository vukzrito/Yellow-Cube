import { Driver } from './driver';
import { Location } from './location';
import { User } from './user.model';

export class Trip {
    id: string;
    driverId: string;
    driver: Driver;
    userId: string;
    user: User;
    startTime: Date;
    endTime: Date;
    pickupAddress: Location;
    dropOffAddress: Location;
}