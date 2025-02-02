Pokémon MVC Application

A simple ASP.NET MVC application that fetches and displays Pokémon details using the PokéAPI. This project is built using .NET Framework and demonstrates basic API integration, data binding, and responsive UI design.

Features :

Search Pokemon: Enter a Pokemon name to fetch its details.
Detailed Information: Displays Pokémon stats, abilities, types, and more.
Responsive Design: Works seamlessly on desktop and mobile devices.
Modern UI: Stylish animations and effects for an engaging user experience.
Error Handling: Gracefully handles invalid Pokémon names and API errors.

Screenshots:
1. Pokémon Search Page
  ![image](https://github.com/user-attachments/assets/26e0c5f2-d170-4aac-a58b-b6b0dcae8fdc)

Search Page
The main search page where users can enter a Pokémon name.

2. Pokémon Details Page
   ![image](https://github.com/user-attachments/assets/dc3af6aa-3003-48c0-b8e9-5d5809bdcc17)

   ![image](https://github.com/user-attachments/assets/b6873eb3-48c5-4150-bbbf-db836c5f8b88)

Details Page
Displays detailed information about the Pokémon, including stats, abilities, and types.

Technologies Used :
Backend: ASP.NET MVC (.NET Framework)
Frontend: HTML, CSS, JavaScript, Bootstrap
API: [PokéAPI](https://pokeapi.co/api/v2/)
NuGet Packages:

RestSharp (for API calls)
Newtonsoft.Json (for JSON parsing)

How It Works
1.The user enters a Pokémon name in the search box.

2.The application makes a request to the PokéAPI using RestSharp.

3.The API response is deserialized into a Pokemon model.

4.The details are displayed in a responsive and visually appealing layout.
