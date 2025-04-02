# TPL Store Application

## General Overview

### Platform & Framework
- The application is built using **WPF** with the latest **.NET 8.0 SDK**.

### Architecture & Navigation
- The architecture is designed to be modular and scalable.
- The application offers **user-friendly navigation** to ensure a seamless user experience.
- **Data persistence** is implemented via a **JSON file** located in the project directory.
- An **Item Repository** class is provided to manage the item data.

---

## Pages and Features

### Login Page
1. **User Authentication**:
    - Users can log in using a **username** and **password**.
    - User information is managed in a **User Repository** class.
  
2. **Post-Login Navigation**:
    - Upon successful login, the app navigates to the **Home Page**.

3. **User Repository**:
    - A sample user (e.g., "admin") is maintained in the **User Repository** for authentication.

### Home Page
1. **Display Previous Orders**:
    - A **DataGrid** is used to display **order header information** from previous orders.
  
2. **Search Functionality**:
    - Users can search for orders using **Order ID**.
  
3. **New Order Creation**:
    - A **"New Order"** button is available to navigate to the **Order Page**.

4. **Order Details Navigation**:
    - Users can navigate to a **read-only view** for a previous order.

### Order Page
1. **Order Line Data Grid**:
    - Displays order lines with the following details:
        - **ComboBox/Drop-down** for item selection by **Item Name**.
        - **SKU ID** (Item ID) field.
        - **Quantity** field.
        - **Item cost** field.
        - **Line total** field.

## Future Improvements

- **Order Header**:
    - Ensure the **Order ID** is unique and auto-incrementing.
    - Display the **username** of the user creating the order.

- **Items Repository & ComboBox**:
    - Implement the functionality where the **ComboBox** auto-populates from the **Item Repository**.
    - Remove **used items** from the **ComboBox** to prevent duplicates.

- **Input Validation & Dynamic Order Management**:
    - Implement restrictions to ensure that only valid quantities can be entered and that items are dynamically added or updated within the order.

- **Order Persistence**:
    - Ensure data persistence for orders in a **JSON file** for long-term storage.

---

## Notes

- This project leverages **WPF** and the **.NET 8.0 SDK** for building a desktop-based application with a smooth user interface.
- The primary goal is to manage orders, items, and customer details efficiently with a clean architecture.
- Some features are yet to be implemented.

---
