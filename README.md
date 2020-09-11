# Barotrauma-Save-Decompressor
Decompress and compress Barotrauma save files.

## Acknowledgement

Many thanks to Undertow Games for writing [the code that made this possible](https://github.com/Regalis11/Barotrauma/blob/master/Barotrauma/BarotraumaShared/SharedSource/Utils/SaveUtil.cs).

## Prerequisites

Microsoft .NET Core 3.1

## Installation

Either build the project from source, or download a compressed executable from the [latest release](https://github.com/Jlobblet/Barotrauma-Save-Decompressor/releases/latest).

## Usage

Run `Barotrauma-Save-Decompressor.exe`.

### Decompression

To decompress a file, click the Browse button in the decompression (top) section.
Navigate to the file's location, and select it.
Then click Decompress.
The resulting folder will be created in the same folder as the file selected, with the same name as the file.

### Compression

To compress a folder, click the Browse button in the compression (bottom) section.
Navigate to the location of the folder to compress, and select it.
Then click Compress.
The compressed file will be in the parent directory of that folder, with the same name and the file extension.

### Example: Adding a Submarine to the List You Can Purchase From

1. Locate your save and decompress it.
2. Open `gamesession.xml`.
3. Find the element called `AvailableSubs`.
4. Add the new submarine to the list.
5. Save, close, compress.
