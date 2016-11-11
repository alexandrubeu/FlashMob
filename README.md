 
Overall 
The arrena has to be mapped to a matrix of pixels.
The pixels represent the mobile device.

Every mmobile device can have a gray pixel - that is represented by the flash light and a colored pixel represented by the screen!


Mobile app requirements
The app has to identify to the server with the mocked position in the array let`s say x-10 y 0 10;

The app must receive real time messages from the server with the pixel to be displayed. And then display it.

Server Side
The server side has to start a realtime hub with signalR. The hub must keep all connected devices with the connection id and position.
The server must create an array of pixels based on some initial configurations - the array must be saved in a databaase or a filestream - or maybe a bitmap.
The server can receive the image that needs to be displayed on the arena crowd. it then adjust the image to fit on the number of devices present in the audience.
The server can take a video and send it frame by frame as images to the devices.

WPF Commander
The wpf commander will be the manager of the crowd assets.
It can send a movie, an image, or a sequence of constructed images.


Initial steps -

Crete the mobile ionic app -
Create a service that connects to server and waits for messages to come by.
	- after connecting to the signalR hub, send a message to the server with the connection_id and the position on the arena:
			{
				connection_id:"guid of connection"
				position:{
					x:
					y:
				}
			}
	- messages received by the mobile app
			{
				flash_pixel : {
					r:
					g:
					b:
					a: #alpha 
				}
				screen_pixel : {
					r:
					g:
					b:
					a:
				}
			}
			
	
Create the server side service:
	Web api with a signar hub.
		- on client connected to the hub, save the device connection id.
		- on client disconected from the hub, delete the device from the storage and regenerate the display matrix.
		- associate the device_connection id and the position . generate the display matrix based on the number of devices registered.
		- the hub should have a send_pixel method with the pixel to send and the target device.
			{
				flash_pixel : {
					r:
					g:
					b:
					a: #alpha 
				}
				screen_pixel : {
					r:
					g:
					b:
					a:
				}
			}
		
