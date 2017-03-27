import { GuidersHubTemplatePage } from './app.po';

describe('abp-project-name-template App', function() {
  let page: GuidersHubTemplatePage;

  beforeEach(() => {
    page = new GuidersHubTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
