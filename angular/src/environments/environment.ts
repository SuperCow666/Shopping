import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Shopping',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44363',
    redirectUri: baseUrl,
    clientId: 'Shopping_App',
    responseType: 'code',
    scope: 'offline_access openid profile role email phone Shopping',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44363',
      rootNamespace: 'Shopping',
    },
  },
} as Environment;
