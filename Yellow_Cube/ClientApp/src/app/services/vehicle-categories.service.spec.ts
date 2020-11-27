import { TestBed } from '@angular/core/testing';

import { VehicleCategoriesService } from './vehicle-categories.service';

describe('VehicleCategoriesService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: VehicleCategoriesService = TestBed.get(VehicleCategoriesService);
    expect(service).toBeTruthy();
  });
});
