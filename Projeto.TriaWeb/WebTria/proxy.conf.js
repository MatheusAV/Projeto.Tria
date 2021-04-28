
  const proxy = [
  {
    context: '/api',
    target: 'http://localhost:44397',
    pathRewrite: {'^/api' : ''}
  }
];
module.exports = proxy;
