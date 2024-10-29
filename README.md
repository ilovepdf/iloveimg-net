![iLoveIMG](https://www.iloveimg.com/img/iloveimg.svg)


## iLoveIMG Api - C# Library
A library in C# for iLoveIMG Api
You can sign up for a iLoveIMG account at https://developer.iloveimg.com

Develop and automate images processing tasks like compress images, convert images, crop images, resize images, rotate images, watermark images, and repair images. Each one with several settings to get your desired results.

## Requirements
Minimum .NET Framework 4.5

## Install

```
### Simple usage looks like:
```csharp
var iloveImgApi = new iLoveImgApi("project_public_id", "project_secret_key");

var task = iloveImgApi.CreateTask<CompressImageTask>();
var file = task.AddFile("https://www.w3.org/People/mimasa/test/imgformat/img/w3c_home.jpg", task.TaskId)
var time = task.Process();
task.DownloadFile("directory-to-download");
```
## Documentation
Please see https://developer.iloveimg.com/docs for up-to-date documentation.

## License
The code is available as open source under the terms of the [MIT License](http://opensource.org/licenses/MIT).
