import React from 'react';
import { GoogleLogin } from 'react-google-login';

const GoogleAuth = ({ onSuccess, onFailure }) => {
    return (
        <GoogleLogin
            clientId="226538140962-0dd0fi61d3k1btr7okji8cdmtmrkum11.apps.googleusercontent.com"
            buttonText="Login with Google"
            onSuccess={onSuccess}
            onFailure={onFailure}
            cookiePolicy={'single_host_origin'}
        />
    );
};

export default GoogleAuth;
