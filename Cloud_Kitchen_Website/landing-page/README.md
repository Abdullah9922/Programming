# Cloud Kitchen landing page

A standalone, framework-free marketing page for the Cloud Kitchen Android app. It does not connect to the Flutter application, a backend, or a database.

## Open locally

Open `index.html` directly in a browser, or serve the folder with any static server. For example, from this folder run `python -m http.server 8000`, then visit `http://localhost:8000`.

## Structure

```text
landing-page/
├── index.html       Page structure and content
├── css/style.css    Visual system, layout, responsiveness
├── js/script.js     Menu, scroll effects, download handling
└── assets/          Reserved for future local images and icons
```

## Customize

- Change colours, spacing, and type rules through the CSS variables at the top of `css/style.css`.
- Change copy directly in `index.html`.
- The app previews are CSS/HTML mockups. Replace their markup with local `<img>` elements if real app screenshots become available; use descriptive `alt` text and `loading="lazy"` for below-fold images.

## Activate the download button

In `js/script.js`, replace:

```js
const APP_DOWNLOAD_URL = "";
```

with the final download address, for example:

```js
const APP_DOWNLOAD_URL = "https://example.com/app.apk";
```

All Download App buttons will then use that address automatically. While it is blank, buttons safely show a “Coming Soon” toast instead.
