export const environment = {
  production: false,
  application: {
    name: 'MyBlog',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44313',
    clientId: 'MyBlog_App',
    dummyClientSecret: '1q2w3e*',
    scope: 'MyBlog',
    showDebugInformation: true,
    oidc: false,
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44313',
    },
  },
  localization: {
    defaultResourceName: 'MyBlog',
  },
};
