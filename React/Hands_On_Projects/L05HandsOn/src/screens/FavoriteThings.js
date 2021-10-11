import React from 'react';
import Things from './Things';
import { BrowserRouter as Router, Route, Link } from 'react-router-dom';

const FavoriteThings = ({ match }) => (
  <div>
    <h2>Favorite Things</h2>
    <ul>
      <li>
        <Link to={`${match.url}/2003 Dodge Dakota Quad Cab 4x4`}>Car</Link>
      </li>
      <li>
        <Link to={`${match.url}/Korean BBQ`}>Food</Link>
      </li>
      <li>
        <Link to={`${match.url}/Pulp Fiction (runner up: The Hitchhiker's Guide to the Galaxy)`}>Movie</Link>
      </li>
    </ul>

    <Route path={`${match.url}/:thingsId`} component={Things} />
    <Route
      exact
      path={match.url}
      render={() => <h3>Please select a topic.</h3>}
    />
  </div>
);

export default FavoriteThings;;