# Google Contacts To Dymo Address
Dymo Label Software is great for creating mailing labels, but keeping multiple addressbooks up to date is hard.  Keep your contacts up to date in Google Contacts, and use this tool to convert them to a Dymo Addressbook suitable for opening in Dymo Label Software v8.5.1.  This tool converts Google Contacts CSV files to Dymo Addressbook ABX files.  

## Latest Version
The latest compiled version is [v.1.0.1](https://github.com/jamielaundon/google-contacts-to-dymo-address/releases/latest)

## Usage:

`google-contacts-to-dymo-address`

Fixed input filename `google.csv`
Fixed output filename `dymo.abx`

## Step-by-step guide

* View your contacts at https://www.google.com/contacts
* Add your contacts to a group, for example *Newsletter*
* Choose *More* > *Export*
   ![More - Export](https://cdn.laundon.org/dymo1.png)
* Select the Group you wish to export
   ![Select The Group](https://cdn.laundon.org/dymo2.png)
* Select Google CSV format, and choose *Export*
* `google.csv` will be downloaded. Place this in the same folder as google-contacts-to-dymo address, ensuring the file is called `google.csv`.
* Run `google-contacts-to-dymo-address`
   ![Run google-contacts-to-dymo-address](https://cdn.laundon.org/dymo3.png)
* Open Dymo Label, and choose *Address Book* > *Import*
   ![Address Book - Import](https://cdn.laundon.org/dymo4.png)
* Select dymo.abx that has been generated
   ![Address Book Successfully Imported](https://cdn.laundon.org/dymo5.png)
* Print your labels
