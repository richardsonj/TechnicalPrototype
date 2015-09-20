To add, edit, or remove data points start the server, and change the URL extension to localhost:[port]/Data/
To view the data currently in a D3 line graph, go to localhost:[port]/Dashboard/Index (This is the default page when you run the server)

The X coordinate is not currently used, because it doesn't make sense in the context of a line graph, since you could create two points with the same X-coordinate. The point's x-coordinate in the line graph is determined by the ID that is generated when it is entered into the server, so they will come up in the order they are created.