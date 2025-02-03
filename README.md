# keepaAPI- **Response**: Returns the response from the Keepa API.

### Get Products
- **URL**: `/api/KeepaApi/products`
- **Method**: `GET`
- **Description**: Fetches product data from the Keepa API and stores it in the database.
- **Query Parameters**:
    - `codes`: The product codes (ASINs) to fetch.
- **Response**: Returns the list of products.

## Project Structure
- **Controllers**: Contains the API controllers.
- **DBContext**: Contains the Entity Framework Core DbContext and related configurations.
- **Models**: Contains the data models and DTOs.
- **Services**: Contains the business logic and services.

## Dependencies
- ASP.NET Core
- Entity Framework Core
- Polly
- System.Text.Json

## Contributing
Contributions are welcome! Please open an issue or submit a pull request.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact
For any questions or feedback, please contact [alaminmain@gmail.com].
