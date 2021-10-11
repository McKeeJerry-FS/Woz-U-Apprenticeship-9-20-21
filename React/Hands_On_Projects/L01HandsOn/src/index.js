import React from 'react';
import ReactDOM from 'react-dom';

const color1 = React.createElement('li', {}, 'Green');
const color2 = React.createElement('li', {}, 'Blue');
const color3 = React.createElement('li', {}, 'Red');

const artist1 = React.createElement('li', {}, 'Regina Spektor');
const artist2 = React.createElement('li', {}, 'Antonin Dvorak');
const artist3 = React.createElement('li', {}, 'Radiohead');

const food1 = React.createElement('li', {}, 'Pizza');
const food2 = React.createElement('li', {}, 'Ceasar Salad');
const food3 = React.createElement('li', {}, 'Gnocchi');

const website1 = React.createElement(
  'li',
  {},
  React.createElement('a', { href: 'https://www.google.com' }, 'www.google.com')
);
const website2 = React.createElement(
  'li',
  {},
  React.createElement(
    'a',
    { href: 'https://www.facebook.com' },
    'www.facebook.com'
  )
);
const website3 = React.createElement(
  'li',
  {},
  React.createElement(
    'a',
    { href: 'https://www.instagram.com' },
    'www.instagram.com'
  )
);

ReactDOM.render(
  React.createElement(
    'div',
    {},
    React.createElement('h1', {}, 'My Favorite Things'),
    React.createElement(
      'ul',
      {},
      React.createElement(
        'li',
        {},
        'Favorite Colors',
        React.createElement('ol', {}, color1, color2, color3)
      ),
      React.createElement(
        'li',
        {},
        'Favorite Music',
        React.createElement('ol', {}, artist1, artist2, artist3)
      ),
      React.createElement(
        'li',
        {},
        'Favorite Food',
        React.createElement('ol', {}, food1, food2, food3)
      ),
      React.createElement(
        'li',
        {},
        'Favorite Websites',
        React.createElement('ol', {}, website1, website2, website3)
      )
    )
  ),
  document.getElementById('root')
);