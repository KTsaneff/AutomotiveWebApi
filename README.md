# AutomotiveWebApi 🚗

A robust ASP.NET Core Web API project built with MongoDB, designed as a wide-range vehicle data platform — similar to an AutoData app. The API supports vehicles like cars, motorcycles, and more, with detailed technical specifications and flexible extension capability.

---

## 🛠️ Technologies Used

- **.NET 8 Web API**
- **MongoDB** (with MongoDB.Driver)
- **JWT Authentication**
- **Swagger (Swashbuckle)** for testing endpoints
- **BCrypt** for secure password hashing
- **React** frontend (in separate repo, in progress)

---

## 📁 Features

### ✅ Authentication

- Register/Login
- Secure JWT-based access
- Role-based authorization (User by default)

### ✅ Vehicle Management

- Add, List, Delete Vehicles
- Each `Vehicle` supports:
  - General details (Make, Model, Year, FuelType, etc.)
  - Engine specs
  - Dimensions (Length, Width, Height, etc.)
  - Wheel & Tyre data
  - Gallery and Image URLs

---

## 🚗 Vehicle Schema Overview

```json
{
  "id": "string",
  "make": "string",
  "model": "string",
  "year": 0,
  "transmission": "string",
  "fuelTankCapacityL": 0,
  "horsePower": 0,
  "torque": 0,
  "fuelType": "string",
  "mileage": 0,
  "color": "string",
  "description": "string",
  "topSpeed": 0,
  "accelerationSec0To100Kph": 0,
  "accelerationSec0To200Kph": 0,
  "fuelConsumptionPer100km": 0,
  "co2EmissionsGPerKm": 0,
  "imageUrl": "string",
  "galleryUrls": [
    "string"
  ],
  "drivetrain": 0,
  "type": 1,
  "engine": {
    "type": "string",
    "cylinders": 0,
    "displacementL": 0,
    "horsepower": 0,
    "torqueNm": 0,
    "fuelSystem": "string",
    "position": "string",
    "aspiration": "string"
  },
  "dimensions": {
    "lengthMm": 0,
    "widthMm": 0,
    "heightMm": 0,
    "wheelbaseMm": 0,
    "weightKg": 0
  },
  "rimSpecs": {
    "diameterInches": 0,
    "widthInches": 0,
    "offsetMm": 0,
    "boltPattern": 0,
    "boltCircleDiameterMm": 0
  },
  "frontTyre": {
    "size": "string",
    "type": "string",
    "loadIndex": 0,
    "speedRating": "string"
  },
  "rearTyre": {
    "size": "string",
    "type": "string",
    "loadIndex": 0,
    "speedRating": "string"
  }
}
